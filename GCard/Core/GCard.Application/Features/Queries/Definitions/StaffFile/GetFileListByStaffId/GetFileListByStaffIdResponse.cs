﻿using GCard.Application.VMs;

namespace GCard.Application.Features.Queries.Definitions.StaffFile.GetFileListByStaffId
{
    public class GetFileListByStaffIdResponse
    {
        public int TotalCount { get; set; }

        public List<StaffFileVM> Files { get; set; }
    }
}
