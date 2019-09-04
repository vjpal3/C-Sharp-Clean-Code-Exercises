using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.MagicNumbersRefactor
{
    class MagicNumbers
    {
        public void ApproveDocument(DocumentStatus status)
        {
            if(status == DocumentStatus.Draft)
            {
                // ....
            }
            else if (status == DocumentStatus.Lodged)
            {
                // ....
            }
        }

        public void RejectDocument(DocumentStatus status)
        {
            switch(status)
            {
                case DocumentStatus.Draft:
                    // ...
                    break;
                case DocumentStatus.Lodged:
                    // ...
                    break;
            }
        }
    }
}
