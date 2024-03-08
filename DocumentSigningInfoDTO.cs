using System;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentSigningInfoDTO
    {
        public object Id { get; set; }

        public DateTime? SigningDate { get; set; }

        public DocumentFlowEmployeeInfoDTO SignerInfoDTO { get; set; }

        public DocumentFlowEmployeeInfoDTO ActuallySignedEmployeeInfoDTO { get; set; }
    }
}