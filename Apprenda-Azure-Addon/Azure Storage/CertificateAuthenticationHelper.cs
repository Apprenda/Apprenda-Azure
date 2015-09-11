using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Azure;

namespace Apprenda.SaaSGrid.Addons.Azure
{
    public static class CertificateAuthenticationHelper
    {
        public static CertificateCloudCredentials GetCredentials(string subscriptionId, string thumbprint, string pfxpassword) => new CertificateCloudCredentials(subscriptionId, GetStoreFromPFX(thumbprint, pfxpassword));

        public static string LoadCertificate(string filename)
        {
            var cert = new X509Certificate();
            cert.Import(filename);
            return cert.ToString(false);
        }

        public static X509Certificate2 GetStoreFromPFX(string pathtoPFX, string password)
        {
            var certCollection = new X509Certificate2Collection();
            certCollection.Import(pathtoPFX, password, X509KeyStorageFlags.PersistKeySet);
            return certCollection[0];
        }

        public static X509Certificate2 GetStoreCertificate(string thumbprint)
        {
            var locations = new List<StoreLocation>
            { 
                StoreLocation.CurrentUser, 
                StoreLocation.LocalMachine
            };
     
            foreach (var location in locations)
            {
                var store = new X509Store("My", location);
                try
                {
                    store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                    X509Certificate2Collection certificates = store.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, false);
               
                    if (certificates.Count == 1)
                    {
                        return certificates[0];
                    }
                }
                finally
                {
                    store.Close();
                }
            }
    
            throw new ApplicationException("No Certificate found");
        }
    }
}
