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

        [Test]
        public void TestPostWithBody()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("createUser", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {
 id= 20,
 first_name= "string",
 last_name = "string",
 position_id = 1,
 organisation_id = 1,
 address_id = 1,
 mob_no = "string",
 alt_mob_no = "string",
 email = "string",
 isDeleted = false,
 address =  new Address(){
 id = 10,
 address_type = "6411641C-F93C-4923-8D28-21FD0F36ADD6",
 street = "string",
 street_2 = "string",
 state_id = 1,
 pincode = "string"}
   
   });
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(201, StatusCode, "Status Code is not 201");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestPostWithoutBody()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("createUser", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {});
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(400, StatusCode, "Status Code is not 400");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestPostWithWrongURL()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("createUsers", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {
 id= 20,
 first_name= "string",
 last_name = "string",
 position_id = 1,
 organisation_id = 1,
 address_id = 1,
 mob_no = "string",
 alt_mob_no = "string",
 email = "string",
 isDeleted = false,
 address =  new Address(){
 id = 10,
 address_type = "6411641C-F93C-4923-8D28-21FD0F36ADD6",
 street = "string",
 street_2 = "string",
 state_id = 1,
 pincode = "string"}
   
   });
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(404, StatusCode, "Status Code is not 404");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestPostWithWrongMethod()
        {
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("createUser", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts() {
 id= 20,
 first_name= "string",
 last_name = "string",
 position_id = 1,
 organisation_id = 1,
 address_id = 1,
 mob_no = "string",
 alt_mob_no = "string",
 email = "string",
 isDeleted = false,
 address =  new Address(){
 id = 10,
 address_type = "6411641C-F93C-4923-8D28-21FD0F36ADD6",
 street = "string",
 street_2 = "string",
 state_id = 1,
 pincode = "string"}
   
   });
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(405, StatusCode, "Status Code is not 405");
            Console.WriteLine(StatusCode);
        }

        [Test]
        public void TestPostAndGet()
        {
            //POST
            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("createUser", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Posts()
            {
                id = 13,
                first_name = "string",
                last_name = "string",
                position_id = 1,
                organisation_id = 1,
                address_id = 1,
                mob_no = "string",
                alt_mob_no = "string",
                email = "string",
                isDeleted = false,
                address = new Address()
                {
                    id = 12,
                    address_type = "6411641C-F93C-4923-8D28-21FD0F36ADD6",
                    street = "string",
                    street_2 = "string",
                    state_id = 1,
                    pincode = "string"
                }

            });
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(201, StatusCode, "Status Code is not 201");
            Console.WriteLine(StatusCode);

            //GET
            request = new RestRequest("getUsers/{id}", Method.GET);
            request.AddUrlSegment("id", 13);
            restResponse = client.Execute<Posts>(request);
            var actualName = client.Execute<Posts>(request).Data.first_name;
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(200, StatusCode, "Status Code is not 200");
            NUnit.Framework.Assert.AreEqual(actualName, "string");
            Console.WriteLine(StatusCode);


        }

        [Test]
        public void TestDelete()
        {

            client = new RestClient("http://localhost:63812/");
            request = new RestRequest("deleteUsers/{id}", Method.DELETE);
            request.AddUrlSegment("id", 11);
            restResponse = client.Execute(request);
            StatusCode = (int)restResponse.StatusCode;
            NUnit.Framework.Assert.AreEqual(200, StatusCode, "Status Code is not 200");
            Console.WriteLine(StatusCode);
        }


    }

}
