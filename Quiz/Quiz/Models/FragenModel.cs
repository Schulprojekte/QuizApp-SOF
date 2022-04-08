namespace Quiz
{
    internal class FragenModel
    {
        private string id;
        private string frage;
        private string antwort1;
        private string antwort2;
        private string antwort3;
        private string antwort4;
        private string korrekt;

        public FragenModel(string i, string f, string a1, string a2, string a3, string a4, string k)
        {
            id = i;
            frage = f;
            antwort1 = a1;
            antwort2 = a2;
            antwort3 = a3;
            antwort4 = a4;
            korrekt = k;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Frage
        {
            get { return frage; }
            set { frage = value; }
        }
        public string Antwort1
        {
            get { return antwort1; }
            set { antwort1 = value; }
        }
        public string Antwort2
        {
            get { return antwort2; }
            set { antwort2 = value; }
        }
        public string Antwort3
        {
            get { return antwort3; }
            set { antwort3 = value; }
        }
        public string Antwort4
        {
            get { return antwort4; }
            set { antwort4 = value; }
        }
        public string Korrekt
        {
            get { return korrekt; }
            set { korrekt = value; }
        }
    }
}