﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace MemberSuite.SDK.Concierge
{
    //public static class IConciergeAPIProxyExtensions
    //{
    //    public static OperationContextScope IfModifiedSince( this IConciergeAPIService api, DateTime dateModifiedSince )
    //    {
    //        OperationContextScope scope = new OperationContextScope( (IContextChannel ) ((ConciergeAPIServiceProxy)api).Channel);

    //        MessageHeader mhModified =     MessageHeader.CreateHeader(ConciergeClientExtensions.CustomHeader.IfModifiedSince, ConciergeClientExtensions.CustomHeader.HeaderNamespace,
    //                                                      dateModifiedSince );

    //        OperationContext.Current.OutgoingMessageHeaders.Add(mhModified);

    //        return scope;
           
            
    //    }
    //}
}
