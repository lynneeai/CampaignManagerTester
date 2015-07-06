﻿using ConsoleApplication1;
using NUnit.Framework;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptorTester.Tests.CampaignManagerTests
{
    [TestFixture()]
    class SubCountForPub
    {
        [TestFixtureSetUp()]
        public void setup()
        {
            TestGlobals.setup();
        }

        [Test()]
        public static void subCountForPubHappyPath()
        {
            //Setup strings
            string applicationKey = TestGlobals.applicationKey;
            string sessionKey = TestGlobals.sessionKey;
            //Guid
            string publicationId = TestGlobals.publicationId;
            //int
            string status = TestGlobals.status;

            string date = TestGlobals.date;

			GenericRequest request = new GenericRequest(TestGlobals.campaignServer, "/dwh/SubscriptionsCount?"
            + "applicationKey=" + applicationKey + "&"
            + "sessionKey=" + sessionKey + "&"
            + "publicationId=" + publicationId + "&"
            + "status=" + status + "&"
            + "date=" + date, null);

            Test mTest = new Test(request);
            AsyncContext.Run(async () => await new HTTPSCalls().runTest(mTest, HTTPOperation.GET));
            string statusCode = HTTPSCalls.result.Key.GetValue("StatusCode").ToString();
            Console.WriteLine("Status Code: " + statusCode);
            Console.WriteLine(HTTPSCalls.result.Value);
            Assert.AreEqual("200", statusCode);
        }
    }
}
