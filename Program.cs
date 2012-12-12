namespace TransferGuardConsoleApplication
{
    using System;
    using System.Xml;
    using System.Security.Cryptography.X509Certificates;
    using TransferGuardServiceReference;

    class Program
    {
        // Set the TransferGuard client Site ID
        const string SiteId = "0000";
        static void Main()
        {
            // Create a new TransferGuard Service Client.
            var client = new TransferServiceClient();

            // Add the client certificate (where the subject is equal to SiteId) from the current user's personal certificate store.  The client certificate must be manually imported into the certificate store.
            if (client.ClientCredentials != null)
                client.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectName, SiteId);

            // Get the current version of the TransferGuard Service
            var version = client.GetVersion();
            Console.WriteLine("Using TransferGuard Service Version: {0}\n", version);
            
            // Create an order.
            Console.WriteLine("Preparing to place order...\n");
            var orderRequest = new OrderRequest
                                   {
                                       HL7Message = @"<ORM_O01><MSH><MSH.1>|</MSH.1><MSH.2>^~\&amp;</MSH.2><MSH.3><HD.1>SENDING_APPLICATION</HD.1></MSH.3><MSH.4><HD.1>SENDING_FACILITY</HD.1></MSH.4><MSH.5><HD.1>PAML</HD.1></MSH.5><MSH.6><HD.1>PAML</HD.1></MSH.6><MSH.7><TS.1>20121204105753.865-0800</TS.1></MSH.7><MSH.9><MSG.1>ORM</MSG.1><MSG.2>O01</MSG.2><MSG.3>ORM_O01</MSG.3></MSH.9><MSH.10>1</MSH.10><MSH.11><PT.1>T</PT.1></MSH.11><MSH.12><VID.1>2.5.1</VID.1></MSH.12></MSH></ORM_O01>",
                                       SiteID = SiteId
                                   };

            // Place an order.
            var orderResponse = client.PlaceOrder(orderRequest);

            // Get the order message ID for tracking purposes.
            Console.WriteLine("Order successfully placed. You can use Message ID {0} to track the message.\n", orderResponse.MessageID);

            // Check if there are any results waiting.
            Console.WriteLine("Checking for pending results...\n");
            var resultRequest = new ResultRequest
                                    { 
                                        SiteID = SiteId
                                    };

            var resultCount = client.GetPendingResultCount(resultRequest);
            Console.WriteLine("There are {0} result(s) waiting to be retieved.\n", resultCount);

            // If there are pending results, retrieve them
            if (resultCount > 0)
            {
                // Retrieve results.
                Console.WriteLine("Retrieving results...\n");
                var results = client.GetResults(resultRequest);
                
                var xmlResults = new XmlDocument();
                var ns = new XmlNamespaceManager(xmlResults.NameTable);
                ns.AddNamespace("v2xml", "urn:hl7-org:v2xml");

                int index = 0;
                foreach (Result result in results.Results)
                {
                    xmlResults.LoadXml(result.HL7Message);
                    XmlNode node = xmlResults.SelectSingleNode("//v2xml:ORU_R01/v2xml:MSH/v2xml:MSH.8", ns);
                    Console.WriteLine("Result Message {0}   ID: {1}", index, node.InnerXml);
                    index++;
                }
            }

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
