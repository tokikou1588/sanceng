//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS11.Model.ModelView
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class feedbackView
    {
        public int f_id { get; set; }
        public string f_title { get; set; }
        public string f_content { get; set; }
        public string fuser_name { get; set; }
        public string fuser_tel { get; set; }
        public string fuser_qq { get; set; }
        public string fuser_email { get; set; }
        public System.DateTime fadd_time { get; set; }
        public string freply_content { get; set; }
        public Nullable<System.DateTime> freply_time { get; set; }
        public bool is_lock { get; set; }
    }
}
