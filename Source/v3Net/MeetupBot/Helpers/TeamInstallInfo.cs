﻿namespace MeetupBot.Helpers
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    public class TeamInstallInfo : Document
    {
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("serviceUrl")]
        public string ServiceUrl { get; set; }

        public override string ToString()
        {
            return $"Team - Id = {this.TeamId}, TenantId = {this.TenantId}, ServiceUrl = {this.ServiceUrl}";
        }
    }
}