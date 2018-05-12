/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using Dolittle.ReadModels;
using Infrastructure.Read;
using MongoDB.Bson.Serialization;

namespace Read.ProjectFeatures
{
    public class ProjectHealthRiskVersion : IReadModel
    {
        public Guid Id { get; set; } // Do we really need this?
        public Guid ProjectId { get; set; }
        public ProjectHealthRisk HealthRisk { get; set; }
        public DateTimeOffset EffectiveFromTime { get; set; }
    }

    public class ProjectHealthRiskVersionClassMap : MongoDbClassMap<ProjectHealthRiskVersion>
    {
        public override void Map(BsonClassMap<ProjectHealthRiskVersion> cm)
        {
            cm.AutoMap();
            cm.MapIdMember(p => p.Id);
        }
    }
}