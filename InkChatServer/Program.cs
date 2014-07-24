using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using InkChat;
namespace InkChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var svcHost = new ServiceHost(typeof(ChatService));
            try
            {
                // Check to see if the service host already has a ServiceMetadataBehavior. If not, add one...
                // var smb = svcHost.Description.Behaviors.Find<ServiceMetadataBehavior>() ?? new ServiceMetadataBehavior();
                //smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                //svcHost.Description.Behaviors.Add(smb);
                // Add MEX endpoint
                //svcHost.AddServiceEndpoint(
                // ServiceMetadataBehavior.MexContractName,
                //MetadataExchangeBindings.CreateMexTcpBinding(),
                //   "mex"
                //);
                // Add application endpoint
                //binding.
                //svcHost.AddServiceEndpoint(typeof(IChatService), binding, "");
                // Open the service host to accept incoming calls
                svcHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                svcHost.Close();
            }
            catch (CommunicationException commProblem)
            {
                Console.WriteLine("There was a communication problem. " + commProblem.Message);
                Console.Read();
            }

        }
    }
}
