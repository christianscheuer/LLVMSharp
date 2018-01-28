
export OSName=$(uname -s)
case $OSName in
    Darwin)
        brew install llvm@4
        cp /usr/local/Cellar/llvm@4/4.0.1/lib/libLLVM.dylib nuget/runtimes/osx-x64/native/libLLVM.dylib
        ;;

    Linux)
        wget -O llvm.deb http://apt.llvm.org/xenial/pool/main/l/llvm-toolchain-4.0/libllvm4.0_4.0~svn305264-1~exp1_amd64.deb
	dpkg -x llvm.deb debtmp
	cp debtmp/usr/lib/x86_64-linux-gnu/libLLVM-4.0.so nuget/runtimes/linux-x64/native/libLLVM.so        
        ;;

    *)
        echo "Unsupported OS $OSName detected"
        exit 1
        ;;
esac

