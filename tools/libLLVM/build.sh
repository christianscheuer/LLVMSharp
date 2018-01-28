
__libs="-lLLVMAArch64AsmParser -lLLVMAArch64AsmPrinter -lLLVMAArch64CodeGen -lLLVMAArch64Desc -lLLVMAArch64Disassembler -lLLVMAArch64Info -lLLVMAArch64Utils -lLLVMAMDGPUAsmParser -lLLVMAMDGPUAsmPrinter -lLLVMAMDGPUCodeGen -lLLVMAMDGPUDesc -lLLVMAMDGPUDisassembler -lLLVMAMDGPUInfo -lLLVMAMDGPUUtils -lLLVMAnalysis -lLLVMARMAsmParser -lLLVMARMAsmPrinter -lLLVMARMCodeGen -lLLVMARMDesc -lLLVMARMDisassembler -lLLVMARMInfo -lLLVMAsmParser -lLLVMAsmPrinter -lLLVMBitReader -lLLVMBitWriter -lLLVMBPFAsmPrinter -lLLVMBPFCodeGen -lLLVMBPFDesc -lLLVMBPFDisassembler -lLLVMBPFInfo -lLLVMCodeGen -lLLVMCore -lLLVMCoroutines -lLLVMCoverage -lLLVMDebugInfoCodeView -lLLVMDebugInfoDWARF -lLLVMDebugInfoMSF -lLLVMDebugInfoPDB -lLLVMDemangle -lLLVMExecutionEngine -lLLVMGlobalISel -lLLVMHexagonAsmParser -lLLVMHexagonCodeGen -lLLVMHexagonDesc -lLLVMHexagonDisassembler -lLLVMHexagonInfo -lLLVMInstCombine -lLLVMInstrumentation -lLLVMInterpreter -lLLVMipo -lLLVMIRReader -lLLVMLanaiAsmParser -lLLVMLanaiCodeGen -lLLVMLanaiDesc -lLLVMLanaiDisassembler -lLLVMLanaiInfo -lLLVMLanaiInstPrinter -lLLVMLibDriver -lLLVMLineEditor -lLLVMLinker -lLLVMLTO -lLLVMMC -lLLVMMCDisassembler -lLLVMMCJIT -lLLVMMCParser -lLLVMMipsAsmParser -lLLVMMipsAsmPrinter -lLLVMMipsCodeGen -lLLVMMipsDesc -lLLVMMipsDisassembler -lLLVMMipsInfo -lLLVMMIRParser -lLLVMMSP430AsmPrinter -lLLVMMSP430CodeGen -lLLVMMSP430Desc -lLLVMMSP430Info -lLLVMNVPTXAsmPrinter -lLLVMNVPTXCodeGen -lLLVMNVPTXDesc -lLLVMNVPTXInfo -lLLVMObjCARCOpts -lLLVMObject -lLLVMObjectYAML -lLLVMOption -lLLVMOrcJIT -lLLVMPasses -lLLVMPowerPCAsmParser -lLLVMPowerPCAsmPrinter -lLLVMPowerPCCodeGen -lLLVMPowerPCDesc -lLLVMPowerPCDisassembler -lLLVMPowerPCInfo -lLLVMProfileData -lLLVMRISCVCodeGen -lLLVMRISCVDesc -lLLVMRISCVInfo -lLLVMRuntimeDyld -lLLVMScalarOpts -lLLVMSelectionDAG -lLLVMSparcAsmParser -lLLVMSparcAsmPrinter -lLLVMSparcCodeGen -lLLVMSparcDesc -lLLVMSparcDisassembler -lLLVMSparcInfo -lLLVMSupport -lLLVMSymbolize -lLLVMSystemZAsmParser -lLLVMSystemZAsmPrinter -lLLVMSystemZCodeGen -lLLVMSystemZDesc -lLLVMSystemZDisassembler -lLLVMSystemZInfo -lLLVMTableGen -lLLVMTarget -lLLVMTransformUtils -lLLVMVectorize -lLLVMX86AsmParser -lLLVMX86AsmPrinter -lLLVMX86CodeGen -lLLVMX86Desc -lLLVMX86Disassembler -lLLVMX86Info -lLLVMX86Utils -lLLVMXCoreAsmPrinter -lLLVMXCoreCodeGen -lLLVMXCoreDesc -lLLVMXCoreDisassembler -lLLVMXCoreInfo -lLLVMXRay"

export OSName=$(uname -s)
case $OSName in
    Darwin)
        export __clang=clang
        export __llvm_include=/usr/local/Cellar/llvm@4/4.0.1/include
        export __llvm_lib=/usr/local/Cellar/llvm@4/4.0.1/lib
        export __zlib_lib=/usr/local/Cellar/zlib/1.2.11/lib
        export __extra_args="-dynamiclib -exported_symbols_list libLLVM.exports -lc++ -lc++abi -lz -lncurses -lSystem -lffi"
        export __dir=nuget/runtimes/osx-x64/native
        export __file=libLLVM.dylib
        ;;

    Linux)
        export __clang=clang++-4.0
        export __llvm_include=/usr/lib/llvm-4.0/include
        export __llvm_lib=/usr/lib/llvm-4.0/lib
        export __zlib_lib=/usr/lib
        export __extra_args="-shared -fPIC -std=c++11 -lz"
        export __dir=nuget/runtimes/linux-x64/native
        export __file=libLLVM.so
        ;;

    *)
        echo "Unsupported OS $OSName detected"
        exit 1
        ;;
esac

$__clang LLVMSharp.cpp -o $__file -I$__llvm_include -L$__llvm_lib -L$__zlib_lib $__libs $__extra_args 

mkdir -p $__dir
rm $__dir/$__file
cp $__file $__dir/$__file
