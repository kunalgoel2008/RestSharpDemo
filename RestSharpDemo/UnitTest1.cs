using RestSharp;
using NUnit.Framework;
using RestSharpDemo.Model;
using System;

namespace RestSharpDemo
{
    [TestFixture]
    public class UnitTest1
    {
        int StatusCode;
        RestClient client;
        RestRequest request;
        IRestResponse restResponse;


        [Test]
        public void TestGetById()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getUsers/{id}", Method.GET);
            request.AddUrlSegment("id", 1);
            restResponse = client.Execute<Posts>(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(200, StatusCode, "Status Code is not 200");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetByIdWrongDataType()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getUsers/{id}", Method.GET);
            request.AddUrlSegment("id", "ABC");
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetIdWrongURL()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getUsersss/{id}", Method.GET);
            request.AddUrlSegment("id", 1);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetIdWrongMethod()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getUsers/{id}", Method.POST);
            request.AddUrlSegment("id", 1);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(405, StatusCode, "Status Code is not 405");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetAll()
        {

            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getAllUsers", Method.GET);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(200, StatusCode, "Status Code is not 200");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetAllWrongURL()
        {

            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getAllUsers/{id}", Method.GET);
            request.AddUrlSegment("id", 1);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestGetAllWrongMethod()
        {

            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("getAllUserss", Method.POST);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }

        /*[Test]
        public void PostWithBody()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(201, StatusCode, "Status Code is not 201");
            Console.WriteLine(StatusCode);
        }*/

        /*[Test]
        public void PostWithoutBody()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }*/

        /*[Test]
        public void PostWithWrongURL()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }*/

        /*[Test]
        public void PostWithWrongMethod()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(405, StatusCode, "Status Code is not 405");
            Console.WriteLine(StatusCode);
        }*/
        /*
        [Test]
        public void PostAndGet()
        {
        //POST
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {id = 8
            , first_name = ""
            , last_name = ""
            , email = ""
            , position_id = 1
            , organisation_id = 1
            , address_id = 1
            , mob_no = ""
            , alt_mob_no = ""
            , isDeleted = false});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(405, StatusCode, "Status Code is not 405");
            Console.WriteLine(StatusCode);

        //GET
            request = new RestRequest("getUsers/{id}", Method.GET);
            request.AddUrlSegment("id", givenId);
            restResponse = client.Execute<Posts>(request);
            var actualName = client.Execute<Posts>(request).Data.first_name;
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(200, StatusCode, "Status Code is not 200");
            NUnit.Framework.Assert.AreEqual(actualName, givenName);
            Console.WriteLine(StatusCode);
 

        }*/

    }

}
