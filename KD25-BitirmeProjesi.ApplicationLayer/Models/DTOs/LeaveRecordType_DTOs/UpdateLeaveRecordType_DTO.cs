﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KD25_BitirmeProjesi.CoreLayer.Enums;

namespace KD25_BitirmeProjesi.ApplicationLayer.Models.DTOs.LeaveRecordType_DTOs
{
    public class UpdateLeaveRecordType_DTO
    {
        public string LeaveRecordName { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
