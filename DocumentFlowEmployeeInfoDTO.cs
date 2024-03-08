namespace UMP.DocumentFlow.Dtos
{
    public class DocumentFlowEmployeeInfoDTO
    {
        public object Id { get; set; }

        public string PersonnelNumber { get; set; }

        public object LeaderId { get; set; }

        public object RoleId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string FullName { get; set; }

        public string Speciality { get; set; }

        public bool IsForeign { get; set; }

        public DepartmentInfoDTO DepartmentInfoDTO { get; set; }
    }
}