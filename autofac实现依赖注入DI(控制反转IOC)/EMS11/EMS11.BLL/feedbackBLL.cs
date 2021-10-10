﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS11.BLL
{
    using EMS11.IBLL;
using EMS11.IDal;
using EMS11.Model;

    public class feedbackBLL : BaseBLL<feedback>,IfeedbackBLL
    {
        public feedbackBLL(IBaseDal<feedback> dal)
        {
            base.dal = dal;
        }
    }
}
