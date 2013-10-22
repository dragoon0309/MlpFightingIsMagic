// Type: <CrtImplementationDetails>.ModuleLoadException
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class ModuleLoadException : System.Exception
  {
    public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

    protected ModuleLoadException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public ModuleLoadException(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public ModuleLoadException(string message)
      : base(message)
    {
    }
  }
}
