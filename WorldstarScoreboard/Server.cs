using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Diagnostics;
using Nancy.Hosting.Self;
using Nancy.Routing;
using Nancy.TinyIoc;
using Newtonsoft.Json;

namespace S3
{
    public class InformationUpdate
    {
        public Player Player1;
        public Player Player2;
        public string round;
        public string tournamentName;
        public string caster;
        public string streamer;
        internal bool isEmpty;
        public string ticker1;
        public string ticker2;
        public string ticker3;
        public string ticker4;
        public string ticker5;
        public string twitchclip;
        public string Comm1Name;
        public string Comm2Name;
        public string Comm3Name;
        public string Comm4Name;
        public string Comm1Twitter;
        public string Comm2Twitter;
        public string Comm3Twitter;
        public string Comm4Twitter;
        public string P1TitleSE;
        public string P2TitleSE;
        public string P3TitleSE;
        public string P4TitleSE;
        public string P5TitleSE;
        public string P6TitleSE;
        public string P1NameSE;
        public string P2NameSE;
        public string P3NameSE;
        public string P4NameSE;
        public string P5NameSE;
        public string P6NameSE;
        public string Crew1Name;
        public string Crew2Name;
        public string Crew1P1Name;
        public decimal Crew1P1Stock = 4;
        public string Crew1P2Name;
        public decimal Crew1P2Stock = 4;
        public string Crew1P3Name;
        public decimal Crew1P3Stock = 4;
        public string Crew1P4Name;
        public decimal Crew1P4Stock = 4;
        public string Crew2P1Name;
        public decimal Crew2P1Stock = 4;
        public string Crew2P2Name;
        public decimal Crew2P2Stock = 4;
        public string Crew2P3Name;
        public decimal Crew2P3Stock = 4;
        public string Crew2P4Name;
        public decimal Crew2P4Stock = 4;
        public string countdown;
        
    }
    public class Player
    {
        public string name;
        public string character;
        public string sponsor;
        public int score;
        public Flag flag;
    }
    public class Server : NancyModule
    {
        public Server()
        {
            Get["/getCurrentValues"] = parameters =>
            {
                InformationUpdate update = Globals.CurrentInformationUpdate;
                string data = JsonConvert.SerializeObject(update);
                Response response = (Response)data;
                response.ContentType = "application/json";
                return response;
            };
        }

        public static NancyHost Run(Uri uri)
        {
            try
            {
                HostConfiguration config = new HostConfiguration();
                config.UrlReservations.CreateAutomatically = true;
                NancyHost host = new NancyHost(config, uri);
                
                host.Start();
                return host;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }

    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            // your customization goes here
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {

            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                    .WithHeader("Access-Control-Allow-Methods", "POST,GET")
                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");

            });
        }
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("assets", @"Content/html/*")
            );
        }
    }
}
