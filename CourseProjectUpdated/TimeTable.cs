//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseProjectUpdated
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeTable
    {
        public int id_timetable { get; set; }
        public Nullable<int> item_code { get; set; }
        public Nullable<int> class_code { get; set; }
        public Nullable<int> teacher_code { get; set; }
        public Nullable<System.DateTime> date_timetable { get; set; }
        public string description_of_item { get; set; }
        public Nullable<int> number_of_item { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Item Item { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
