//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Friendship
    {
        public int FriendshipID { get; set; }
        public string ReceiverUserID { get; set; }
        public string SenderUserID { get; set; }
        public bool IsAccepted { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
