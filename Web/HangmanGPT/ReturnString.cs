using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

public string GetCorrectWord()
{
    string url = "https://otv-hangman.azurewebsites.net/api/GetWord";
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    string jsonString;

    using (Stream stream = response.GetResponseStream())
    {
        StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
        jsonString = reader.ReadToEnd();
    }

    JObject json = JObject.Parse(jsonString);
    string correctWord = (string)json["word"];

    return correctWord;
}
