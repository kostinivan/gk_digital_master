#pragma once
#include <string>
#include <vector>

class VectorGroomer{
    public:
        VectorGroomer() = delete;
        VectorGroomer(std::vector<std::string> input, uint64_t input_max_length) : 
            to_groom_(input),
            max_length_(input_max_length)
            {};
        ~VectorGroomer() = default;

        std::vector<std::string> get_result();

    private:
        void perform_groom();
        std::vector<std::string> to_groom_;
        uint64_t max_length_ = 3;
};