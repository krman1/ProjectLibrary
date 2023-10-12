﻿
namespace ProjectLibrary.Entities
{
    public class Project : EntityBase
    {
        public string? Name { get; set; }
        public string? City { get; set; }    
        public string? Description { get; set; } 
        public string? Architect { get; set; }
        public override string ToString() => $"Id:{Id}, Name: {Name}, City: {City}, Description: {Description}, Architect: {Architect}";
        
    }
}
