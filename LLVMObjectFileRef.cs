﻿namespace LLVMSharp
{
    using System;

    public partial struct LLVMObjectFileRef : IEquatable<LLVMObjectFileRef>
    {
        public bool Equals(LLVMObjectFileRef other)
        {
            return this.Pointer == other.Pointer;
        }

        public override bool Equals(object obj)
        {
            if (obj is LLVMObjectFileRef)
            {
                return this.Equals((LLVMObjectFileRef)obj);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(LLVMObjectFileRef op1, LLVMObjectFileRef op2)
        {
            return op1.Equals(op2);
        }

        public static bool operator !=(LLVMObjectFileRef op1, LLVMObjectFileRef op2)
        {
            return !(op1 == op2);
        }

        public override int GetHashCode()
        {
            return this.Pointer.GetHashCode();
        }
    }
}
