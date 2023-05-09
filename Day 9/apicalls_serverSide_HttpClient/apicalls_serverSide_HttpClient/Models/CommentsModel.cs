namespace apicalls_serverSide_HttpClient.Models
{
    public class CommentsModel
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        List<CommentsModel> commentsData = new List<CommentsModel>();

        public List<CommentsModel> getComments()
        {
            //we will make the call here useing HttpClient 

            HttpClient client = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/comments";

            //we need to clear the default datatype format from the calling environment,
            //google chrome has a default format of XML
            //IE has JSON
            //Windows APP has Binary text as default
            //Linux system has their own format, and so as Mac

            client.DefaultRequestHeaders.Accept.Clear();
            //we need to add JSON as a format
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;
            //if call successful, we will read the data, else throw excecption
            if (call.IsSuccessStatusCode)
            {
                var result = call.Content.ReadAsAsync<List<CommentsModel>>();
                result.Wait();
                commentsData = result.Result;
                return commentsData;
            }
            else
            {
                throw new Exception("Could not get data from server");
            }


            return commentsData;
        }

    }
}




