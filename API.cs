using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TolokaManager.Models
{
    public class API
    {
        private RestRequest restRequest { get; set; }
        public API()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("cache-control", "no-cache");
            restRequest.AddHeader("Connection", "keep-alive");
            restRequest.AddHeader("Cookie", "JSESSIONID=node0e9toaw1jxx2m1ujgyijdnnhh640.node0");
            restRequest.AddHeader("Accept-Encoding", "gzip, deflate");
            restRequest.AddHeader("Host", "toloka.yandex.ru");
            restRequest.AddHeader("Cache-Control", "no-cache");
            restRequest.AddHeader("Accept", "*/*");
            restRequest.AddHeader("Authorization", $"OAuth {Constants.OAUTH_TOKEN}");
        }

        public void DownloadFile(string file_guid,string filePath)
        {
            var client = new RestClient($"{Constants.ATTACHMENTS_URL}/{file_guid}/download");
            var data = client.DownloadData(restRequest);
            File.WriteAllBytes(filePath, data);
        }

        public string GetFileExtension(string file_guid)
        {
            var client = new RestClient($"{Constants.ATTACHMENTS_URL}{file_guid}");
            IRestResponse response = client.Execute(restRequest);
            JObject attachment = JObject.Parse(response.Content);
            return Path.GetExtension(attachment["name"].ToString());
        }


        public List<Answer> GetAttachments(int pool_id, bool validated,DateTime dateStart,DateTime dateEnd)
        {
            var status = validated ? Constants.STATUS_ACCEPTED : Constants.STATUS_SUBMITTED;
            var assigmentsUrl = $"{Constants.ASSIGMENTS_URL}?limit=10000&pool_id={pool_id}&status={status}";
            if (dateStart != DateTime.MinValue)
            {
                var date = dateStart.ToUniversalTime().ToString("o");
                assigmentsUrl += $"&created_gte={date}";
            }
            if (dateEnd != DateTime.MinValue)
            {
                var date = dateEnd.ToUniversalTime().ToString("o");
                assigmentsUrl += $"&created_lte={date}";
            }
            var client = new RestClient(assigmentsUrl);
            IRestResponse response = client.Execute(restRequest);
            JObject attachment = JObject.Parse(response.Content);
            IList<JToken> results = attachment["items"].Children().ToList();
            List<Answer> searchResults = new List<Answer>();
            foreach (JToken result in results)
            {
                Answer searchResult = result.ToObject<Answer>();
                searchResult.left = new List<string>();
                searchResult.right = new List<string>();
                if (result["solutions"] != null)
                    foreach (var sol in result["solutions"])
                    {
                        var s = sol["output_values"];
                        searchResult.left.Add(s["left"].ToString());
                        searchResult.right.Add(s["right"].ToString());
                    }

                searchResults.Add(searchResult);
            }
            return searchResults;
        }
    }
}
