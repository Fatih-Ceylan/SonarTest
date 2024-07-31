﻿namespace BaseProject.Application.DTOs.Identity.AppUser
{
    public class UpdateUserResponseDTO
    {
        public string Id { get; set; }

        public string? ProfileImagePath { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string CompanyId { get; set; }

        public string BranchId { get; set; }

        public string DepartmentId { get; set; }

        public bool Succeed { get; set; }

        public string Message { get; set; }
    }
}