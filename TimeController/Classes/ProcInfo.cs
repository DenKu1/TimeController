using System;

namespace TimeController
{
    [Serializable]
    public class ProcInfo
    {
        public string processName;
        public string processTitle;
        public static bool whatShow = true;

        public ProcInfo(string procName, string procTitle)
        {
            processName = procName;
            processTitle = procTitle;
        }

        public ProcInfo(string procNameAndTitle)
        {
            processName = procNameAndTitle;
            processTitle = processName;
        }

        public override string ToString()
        {
            if (whatShow == true)
                return processTitle;
            return processName;
        }

        public static bool operator ==(ProcInfo obj1, ProcInfo obj2)
        {
            if (obj1.processName == obj2.processName)
                return true;
            return false;
        }

        public static bool operator !=(ProcInfo obj1, ProcInfo obj2)
        {
            if (obj1.processName != obj2.processName)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return processName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;

            ProcInfo objPrInf = (ProcInfo)obj;
            return processName == objPrInf.processName;
        }

        public bool Equals(ProcInfo other)
        {
            if (other == null)
                return false;

            return processName == other.processName;
        }

    }
}
