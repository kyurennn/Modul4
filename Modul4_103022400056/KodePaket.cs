using Modul4_103022400056;
using System;

namespace Modul4_103022400056
{ 
    public class kodePaket
    {
        private Dictionary<string, string> tabelPaket = new Dictionary<string, string>()
        {
            {"Basic", "P201"},
            {"Standard", "P202"},
            {"Premium", "P203"},
            {"Unlimited", "P204"},
            {"Gaming", "P205"},
            {"Streaming", "P206"},
            {"Family", "P207"},
            {"Business", "P208"},
            {"Student", "P209"},
            {"Traveler", "P210"}
        };
    public string getKodePaket(string namaPaket)
    {
        if (tabelPaket.ContainsKey(namaPaket))
        {
             return tabelPaket[namaPaket];
        }
        else
        {
         return "Kode paket tidak ditemukan";
        }
    }
    }
}

