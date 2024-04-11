using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MediatorDP
{
    public interface IChatroom
    {
        // Modified by sanjit
        void SendMessage(string msg, Participant participant);
        void RegisterUser(Participant participant);
    }
}
