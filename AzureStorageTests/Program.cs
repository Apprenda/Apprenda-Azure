using System;
using System.Collections.Generic;
using Apprenda.SaaSGrid.Addons;
using Apprenda.SaaSGrid.Addons.Azure.Storage;

namespace AzureStorageTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var addonparameterlist = new List<AddonParameter>
            {
                new AddonParameter() {Key = "newstorageaccount", Value = "true"},
                new AddonParameter() {Key = "storageaccountname", Value = "axafinancial"},
                new AddonParameter() {Key = "containername", Value = "axablob"}
            };

            var provisioningrequest = new AddonProvisionRequest()
            {
                DeveloperParameters = addonparameterlist,
                Manifest = new AddonManifest()
                {
                    AllowUserDefinedParameters = true,
                    Author = "Chris Dutra",
                    IsEnabled = true,
                    Version = "1.1",
                    Vendor = "Apprenda",
                    Properties = new List<AddonProperty>()
                    {
                        new AddonProperty() { Key="AzureManagementSubscriptionID", Value = "4b446bb7-79db-49e1-b5b9-5c3f2cc08a58"},
                        new AddonProperty() { Key="AzureAuthenticationKey", Value="C:/users/cdutra/desktop/cdutra.cer" },
                        new AddonProperty() { Key="AzureURL", Value = "https://management.core.windows.net" },
                        new AddonProperty() { Key="GeoReplicationEnabled", Value="true" },
                        new AddonProperty() { Key="Location", Value="East US"}
                    }
                }
            };

            var storageAddon = new AzureStorageAddon();
            var response = storageAddon.Provision(provisioningrequest);
            Console.Read();

        }
    }
}
