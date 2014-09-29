﻿using System.Collections.Generic;

namespace Dargon.Transport
{
   public class DefaultDtpNodeFactory : IDtpNodeFactory
   {
      public DtpNode CreateNode(bool acceptIncomingConnections, string defaultPipeName = "dargon", IEnumerable<IInstructionSet> instructionSets = null)
      {
         return new DtpNode(acceptIncomingConnections, defaultPipeName, instructionSets);
      }
   }
}