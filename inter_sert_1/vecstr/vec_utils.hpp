#include<vector>
#include<iostream>

namespace vec_utils
{

std::string gen_random(const int len) {
    // generate random string from given chars except comma.
    static const char alphanum[] =
        "0123456789"
        "~`!@#$%^&*(){}[]|/.<>?"
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        "abcdefghijklmnopqrstuvwxyz";
    std::string tmp_s;
    tmp_s.reserve(len);

    for (int i = 0; i < len; ++i) {
        tmp_s += alphanum[rand() % (sizeof(alphanum) - 1)];
    }
    
    return tmp_s;
}

template <typename T> void printVector(std::vector<T> input){
    if (input.empty()){
        cout << "[]";
    }
    cout << "[" << input.at(0);
    for (int i = 0; i < input.size(); i++){
        cout << ", " << input.at(i);
    }
    cout << "]" << endl;
}

std::vector<std::string> generateVector(uint64_t N){
    std::vector<std::string> result;
    result.reserve(N);
    for (int i = 0; i < N; i++){
        auto len = rand() % 11 + 1; // generate random length to every string from 1 to 12 borders included
        result.push_back(gen_random(len));
    }
    return result;
}

std::vector<std::string> getVectorFromUser(){
    std::cout << "Give me the length of vector: ";
    uint16_t N = 0;
    std::cin >> N;
    std::string elem;
    std::vector<std::string> result;
    result.reserve(N);
    for (int i = 0; i < N; i++){
        std::cout << "Element #" << i << ": ";
        std::cin >> elem;
        result.push_back(elem);
        std::cout << std::endl;
    }
    return result;
}

}