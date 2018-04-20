using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker docwor;
            ExpertDocumentWorker expdocwor;
            ProDocumentWorker prodocwor;
            int[] ekey = new int[3];
            int[] pkey = new int[4];
            int key,dostup = 0;
            ekey[0] = 1450;
            ekey[1] = 4894;
            ekey[2] = 1641;
            pkey[0] = 1686;
            pkey[1] = 4681;
            pkey[2] = 7216;
            pkey[3] = 9742;
            Console.Write("Please, enter your key ");
            key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                if (key == ekey[i])
                    dostup += 2;
            for (int i = 0;i<4;i++)
                if (key == pkey[i])
                    dostup += 1;
            if (dostup == 2)
            {
                expdocwor = new ExpertDocumentWorker();
                Console.WriteLine(expdocwor.OpenDocument());
                Console.WriteLine(expdocwor.EditDocument());
                Console.WriteLine(expdocwor.SaveDocument());
            }
            else if (dostup == 1)
            {
                prodocwor = new ProDocumentWorker();
                Console.WriteLine(prodocwor.OpenDocument());
                Console.WriteLine(prodocwor.EditDocument());
                Console.WriteLine(prodocwor.SaveDocument());
            }

            else
            {
                docwor = new DocumentWorker();
                Console.WriteLine(docwor.OpenDocument());
                Console.WriteLine(docwor.EditDocument());
                Console.WriteLine(docwor.SaveDocument());
            }
            Console.ReadKey();
        }
    }
    class DocumentWorker
    {
        public virtual string OpenDocument ()
        {
            return "Document was opened";
        }
        public virtual string EditDocument()
        {
            return "Editing is available in the version Pro";
        }
        public virtual string SaveDocument()
        {
            return "Saving is available in the version Pro";
        }
        
    }
    class ProDocumentWorker : DocumentWorker
    {      
        public string EditDocument()
        {
            return "Document was edited";
        }
        public string SaveDocument()
        {
            return "Document was saved in old format. Save in another formats avaliable in Exp version";
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public string SaveDocument()
        {
            return "Document was saved in new format";
        }
    }
}
