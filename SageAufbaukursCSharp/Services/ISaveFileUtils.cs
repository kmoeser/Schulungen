using System;

namespace SageAufbaukursCSharp.Services
{
    public interface ISaveFileUtils
    {
        Exception Fault { get; }      //Wenn beim Speichern qwas schief geht
        string Message { get; }      //Benutzernachricht

        bool Save(object beleg);
        bool Save(object beleg, string path);

    }
}
