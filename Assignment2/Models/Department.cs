﻿namespace Assignment2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
