﻿using CargoTrack.OrganizationService.Data.Contracts;
using CargoTrack.OrganizationService.Data.Entities;
using CargoTrack.OrganizationService.Data.Repositories.Base;

namespace CargoTrack.OrganizationService.Data.Repositories
{
    public class OrganizationRepository : Repository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(DataDbContext dataDbContext) : base(dataDbContext)
        { }
    }
}
