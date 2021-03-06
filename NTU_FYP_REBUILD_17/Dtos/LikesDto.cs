﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NTU_FYP_REBUILD_17.Dtos
{
    public class LikesDto 
    {
		[Required]
		public int likeID { get; set; }
		public int socialHistoryID { get; set; }
		public int isApproved { get; set; }
		public int isDeleted { get; set; }
		[StringLength(150)]
		public string likeItem { get; set; }

	}
}