using System.Collections.Generic;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentApprovingCycleResultInfoDTO
    {
        public object Id { get; set; }

        public int CycleNumber { get; set; }

        public IEnumerable<DocumentApprovingInfoDTO> DocumentApprovingsInfoDTO { get; set; }
    }
}