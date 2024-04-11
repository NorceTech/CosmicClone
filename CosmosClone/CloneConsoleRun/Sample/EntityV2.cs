﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace CloneConsoleRun.Sample
{
    using System;
    using System.Collections.Generic;

    using CosmosCloneCommon.Model;

    public class EntityV2
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string EmployeeId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<EntityKey> BaseKeys { get; set; }
        public string _etag { get; set; }
        public int SuperId { get; set; }
        public string id { get; set; }
        public string EntityType { get; set; }
        public static EntityV2 getRandomEntity()
        {
            var entity = new EntityV2();
            entity.SuperId = RandomNumberGenerator.GetNext();
            entity.id = Guid.NewGuid().ToString();
            entity.FullName = "Test Sample Name " + entity.SuperId.ToString();
            entity.Description = "Test Sample Description " + entity.SuperId.ToString();
            entity.EntityType = RandomNumberGenerator.GetRandomEntityType();
            var employeeid = RandomNumberGenerator.GetNext();
            entity.EmailAddress = "intialTest" + employeeid.ToString() + "@test.com";
            entity.PhoneNumber = RandomNumberGenerator.GetNext().ToString();
            entity.IsActive = true;
            entity.ModifiedTime = DateTime.UtcNow;

            entity.BaseKeys = new List<EntityKey>();
            entity.BaseKeys.Add(EntityKey.getRandomEntityKey());
            entity.BaseKeys.Add(EntityKey.getRandomEntityKey());
            entity.BaseKeys.Add(EntityKey.getRandomEntityKey());
            entity.BaseKeys.Add(EntityKey.getRandomEntityKey());
            entity.BaseKeys.Add(EntityKey.getRandomEntityKey());
            return entity;
        }
    }






}
