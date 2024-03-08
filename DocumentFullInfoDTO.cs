using System.Collections.Generic;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentFullInfoDTO
    {
        public DocumentDTO DocumentDTO { get; set; }

        public IEnumerable<DocumentRelationInfoDTO> DocumentRelationsInfoDTO { get; set; }

        public IEnumerable<DocumentFileInfoDTO> DocumentFilesInfoDTO { get; set; }

        public IEnumerable<DocumentApprovingCycleResultInfoDTO> DocumentApprovingCycleResultsInfoDTO { get; set; }

        public IEnumerable<DocumentChargeSheetInfoDTO> DocumentChargeSheetsInfoDTO { get; set; }
    }
}