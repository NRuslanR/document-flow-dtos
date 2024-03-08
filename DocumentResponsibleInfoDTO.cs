namespace UMP.DocumentFlow.Dtos
{
    public class DocumentResponsibleInfoDTO
    {
        public object Id { get; set; }

        public string Name { get; set; }

        public string TelephoneNumber { get; set; }

        public DepartmentInfoDTO DepartmentInfoDTO { get; set; }
    }
}