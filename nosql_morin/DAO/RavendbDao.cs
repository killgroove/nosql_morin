using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nosql_morin.DAO
{
    public class RavendbDao
    {
        // Connection to RavenDB database

        public void RavendbDaoConnect()
        {
            //using (IDocumentStore store = new DocumentStore
            //{
            //    Urls = new[]                        // URL to the Server,
            //    {                                   // or list of URLs 
            //        "http://live-test.ravendb.net"  // to all Cluster Servers (Nodes)
            //    },
            //    Database = "Northwind",             // Default database that DocumentStore will interact with
            //    Conventions = { }                   // DocumentStore customizations
            //})
            //{
            //    store.Initialize();                 // Each DocumentStore needs to be initialized before use.
            //                                        // This process establishes the connection with the Server
            //                                        // and downloads various configurations
            //                                        // e.g. cluster topology or client configuration
            //}
        }
    }
}