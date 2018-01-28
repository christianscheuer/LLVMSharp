
export OSName=$(uname -s)
case $OSName in
    Darwin)
        brew install llvm@4
        cp /usr/local/Cellar/llvm@4/4.0.1/lib/libLLVM.dylib runtimes/osx-x64/native/libLLVM.dylib
        ;;

    Linux)
        wget http://apt.llvm.org/xenial/pool/main/l/llvm-toolchain-4.0/llvm-4.0_4.0~svn305264-1~exp1_amd64.deb
        
        ;;

    *)
        echo "Unsupported OS $OSName detected"
        exit 1
        ;;
esac

