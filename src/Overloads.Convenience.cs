﻿namespace LLVMSharp
{
    partial class LLVM
    {
        public static LLVMValueRef[] GetNamedMetadataOperands(LLVMModuleRef m, string name)
        {
            uint count = GetNamedMetadataNumOperands(m, name);
            var buffer = new LLVMValueRef[count];

            if (count > 0)
            {
                GetNamedMetadataOperands(m, name, out buffer[0]);
            }

            return buffer;
        }

        public static LLVMTypeRef FunctionType(LLVMTypeRef returnType, LLVMTypeRef[] paramTypes, LLVMBool isVarArg)
        {
            if (paramTypes.Length == 0)
            {
                return FunctionType(returnType, out LLVMTypeRef dummy, 0, isVarArg);
            }

            return FunctionType(returnType, out paramTypes[0], (uint)paramTypes.Length, isVarArg);
        }

        public static LLVMTypeRef[] GetParamTypes(LLVMTypeRef functionTy)
        {
            uint count = CountParamTypes(functionTy);
            var buffer = new LLVMTypeRef[count];

            if (count > 0)
            {
                GetParamTypes(functionTy, out buffer[0]);
            }

            return buffer;
        }

        public static LLVMTypeRef StructTypeInContext(LLVMContextRef c, LLVMTypeRef[] elementTypes, LLVMBool packed)
        {
            if (elementTypes.Length == 0)
            {
                return StructTypeInContext(c, out LLVMTypeRef dummy, 0, packed);
            }

            return StructTypeInContext(c, out elementTypes[0], (uint)elementTypes.Length, packed);
        }

        public static LLVMTypeRef StructType(LLVMTypeRef[] elementTypes, LLVMBool packed)
        {
            if (elementTypes.Length == 0)
            {
                return StructType(out LLVMTypeRef dummy, 0, packed);
            }

            return StructType(out elementTypes[0], (uint)elementTypes.Length, packed);
        }

        public static void StructSetBody(LLVMTypeRef structTy, LLVMTypeRef[] elementTypes, LLVMBool packed)
        {
            if (elementTypes.Length == 0)
            {
                StructSetBody(structTy, out LLVMTypeRef dummy, 0, packed);
                return;
            }

            StructSetBody(structTy, out elementTypes[0], (uint)elementTypes.Length, packed);
        }

        public static LLVMTypeRef[] GetStructElementTypes(LLVMTypeRef structTy)
        {
            uint count = CountStructElementTypes(structTy);
            var buffer = new LLVMTypeRef[count];

            if (count > 0)
            {
                GetStructElementTypes(structTy, out buffer[0]);
            }

            return buffer;
        }

        public static LLVMValueRef ConstStructInContext(LLVMContextRef c, LLVMValueRef[] constantVals, LLVMBool packed)
        {
            if (constantVals.Length == 0)
            {
                return ConstStructInContext(c, out LLVMValueRef dummy, 0, packed);
            }

            return ConstStructInContext(c, out constantVals[0], (uint)constantVals.Length, packed);
        }

        public static LLVMValueRef ConstStruct(LLVMValueRef[] constantVals, LLVMBool packed)
        {
            if (constantVals.Length == 0)
            {
                return ConstStruct(out LLVMValueRef dummy, 0, packed);
            }

            return ConstStruct(out constantVals[0], (uint)constantVals.Length, packed);
        }

        public static LLVMValueRef ConstArray(LLVMTypeRef elementTy, LLVMValueRef[] constantVals)
        {
            if (constantVals.Length == 0)
            {
                return ConstArray(elementTy, out LLVMValueRef dummy, 0);
            }

            return ConstArray(elementTy, out constantVals[0], (uint)constantVals.Length);
        }

        public static LLVMValueRef ConstNamedStruct(LLVMTypeRef structTy, LLVMValueRef[] constantVals)
        {
            if (constantVals.Length == 0)
            {
                return ConstNamedStruct(structTy, out LLVMValueRef dummy, 0);
            }

            return ConstNamedStruct(structTy, out constantVals[0], (uint)constantVals.Length);
        }

        public static LLVMValueRef ConstVector(LLVMValueRef[] scalarConstantVars)
        {
            if (scalarConstantVars.Length == 0)
            {
                return ConstVector(out LLVMValueRef dummy, 0);
            }

            return ConstVector(out scalarConstantVars[0], (uint)scalarConstantVars.Length);
        }

        public static LLVMValueRef ConstGEP(LLVMValueRef constantVal, LLVMValueRef[] constantIndices)
        {
            if (constantIndices.Length == 0)
            {
                return ConstGEP(constantVal, out LLVMValueRef dummy, 0);
            }

            return ConstGEP(constantVal, out constantIndices[0], (uint)constantIndices.Length);
        }

        public static LLVMValueRef ConstInBoundsGEP(LLVMValueRef constantVal, LLVMValueRef[] constantIndices)
        {
            if (constantIndices.Length == 0)
            {
                return ConstInBoundsGEP(constantVal, out LLVMValueRef dummy, 0);
            }

            return ConstInBoundsGEP(constantVal, out constantIndices[0], (uint)constantIndices.Length);
        }

        public static LLVMValueRef ConstExtractValue(LLVMValueRef aggConstant, uint[] idxList)
        {
            if (idxList.Length == 0)
            {
                return ConstExtractValue(aggConstant, out uint dummy, 0);
            }

            return ConstExtractValue(aggConstant, out idxList[0], (uint)idxList.Length);
        }

        public static LLVMValueRef ConstInsertValue(LLVMValueRef aggConstant, LLVMValueRef elementValueConstant, uint[] idxList)
        {
            if (idxList.Length == 0)
            {
                return ConstInsertValue(aggConstant, elementValueConstant, out uint dummy, 0);
            }

            return ConstInsertValue(aggConstant, elementValueConstant, out idxList[0], (uint)idxList.Length);
        }

        public static LLVMValueRef[] GetParams(LLVMValueRef fn)
        {
            uint count = CountParams(fn);
            var buffer = new LLVMValueRef[count];

            if (count > 0)
            {
                GetParams(fn, out buffer[0]);
            }

            return buffer;
        }

        public static LLVMValueRef MDNodeInContext(LLVMContextRef c, LLVMValueRef[] vals)
        {
            if (vals.Length == 0)
            {
                return MDNodeInContext(c, out LLVMValueRef dummy, 0);
            }

            return MDNodeInContext(c, out vals[0], (uint)vals.Length);
        }

        public static LLVMValueRef MDNode(LLVMValueRef[] vals)
        {
            if (vals.Length == 0)
            {
                return MDNode(out LLVMValueRef dummy, 0);
            }

            return MDNode(out vals[0], (uint)vals.Length);
        }

        public static LLVMValueRef[] GetMDNodeOperands(LLVMValueRef v)
        {
            uint count = GetMDNodeNumOperands(v);
            var buffer = new LLVMValueRef[count];

            if (count > 0)
            {
                GetMDNodeOperands(v, out buffer[0]);
            }

            return buffer;
        }

        public static LLVMBasicBlockRef[] GetBasicBlocks(LLVMValueRef fn)
        {
            uint count = CountBasicBlocks(fn);
            var buffer = new LLVMBasicBlockRef[count];

            if (count > 0)
            {
                GetBasicBlocks(fn, out buffer[0]);
            }

            return buffer;
        }

        public static void AddIncoming(LLVMValueRef phiNode, LLVMValueRef[] incomingValues, LLVMBasicBlockRef[] incomingBlocks, uint count)
        {
            if (count == 0)
            {
                return;
            }

            AddIncoming(phiNode, out incomingValues[0], out incomingBlocks[0], count);
        }

        public static void AddIncoming(LLVMValueRef phiNode, LLVMValueRef[] incomingValues, LLVMBasicBlockRef[] incomingBlocks)
        {
            AddIncoming(phiNode, incomingValues, incomingBlocks, (uint)incomingValues.Length);
        }

        public static LLVMValueRef BuildAggregateRet(LLVMBuilderRef param0, LLVMValueRef[] retVals)
        {
            return BuildAggregateRet(param0, out retVals[0], (uint)retVals.Length);
        }

        public static LLVMValueRef BuildInvoke(LLVMBuilderRef param0, LLVMValueRef fn, LLVMValueRef[] args, LLVMBasicBlockRef then, LLVMBasicBlockRef Catch, string name)
        {
            if (args.Length == 0)
            {
                return BuildInvoke(param0, fn, out LLVMValueRef dummy, 0, then, Catch, name);
            }

            return BuildInvoke(param0, fn, out args[0], (uint)args.Length, then, Catch, name);
        }

        public static LLVMValueRef BuildGEP(LLVMBuilderRef b, LLVMValueRef pointer, LLVMValueRef[] indices, string name)
        {
            if (indices.Length == 0)
            {
                return BuildGEP(b, pointer, out LLVMValueRef dummy, 0, name);
            }

            return BuildGEP(b, pointer, out indices[0], (uint)indices.Length, name);
        }

        public static LLVMValueRef BuildInBoundsGEP(LLVMBuilderRef b, LLVMValueRef pointer, LLVMValueRef[] indices, string name)
        {
            if (indices.Length == 0)
            {
                return BuildInBoundsGEP(b, pointer, out LLVMValueRef dummy, 0, name);
            }

            return BuildInBoundsGEP(b, pointer, out indices[0], (uint)indices.Length, name);
        }

        public static LLVMValueRef BuildCall(LLVMBuilderRef param0, LLVMValueRef fn, LLVMValueRef[] args, string name)
        {
            if (args.Length == 0)
            {
                return BuildCall(param0, fn, out LLVMValueRef dummy, 0, name);
            }

            return BuildCall(param0, fn, out args[0], (uint)args.Length, name);
        }

        public static LLVMGenericValueRef RunFunction(LLVMExecutionEngineRef ee, LLVMValueRef f, LLVMGenericValueRef[] args)
        {
            if (args.Length == 0)
            {
                return RunFunction(ee, f, 0, out LLVMGenericValueRef dummy);
            }

            return RunFunction(ee, f, (uint)args.Length, out args[0]);
        }
    }
}