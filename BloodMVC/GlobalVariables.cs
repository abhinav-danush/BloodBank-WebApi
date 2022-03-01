using System.Net.Http.Headers;

namespace BloodMVC
{
    public class GlobalVariables
    {
        public static HttpClient webapiClient = new HttpClient();
        static GlobalVariables()
        {
            webapiClient.BaseAddress = new Uri("https://localhost:44378/swagger/api/");
            webapiClient.DefaultRequestHeaders.Clear();
            webapiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
