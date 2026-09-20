// The customer-journey proof for a C++ Visual Studio solution (J25).
#include <cstdio>
#include <fstream>

int main()
{
    const char* marker = "dslp msbuildproof cpp ok";
    std::printf("%s\n", marker);
    std::ofstream out("dslp_msbuildproof_cpp.txt");
    out << marker << "\n";
    return 0;
}
