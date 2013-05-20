﻿using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [System.Serializable]
    public class DoesNotEndWithOneOfTheFollowing : EndsWithOneOfTheFollowing
    {
        public override bool IsNegative
        {
            get { return true; }
        }
    }
}