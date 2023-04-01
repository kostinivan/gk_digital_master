#include "../vecstr.hpp"

using namespace std;

vector<string> VectorGroomer::get_result(){
    perform_groom();
    return to_groom_;
}

void VectorGroomer::perform_groom(){
    vector<string> result;
    result.reserve(to_groom_.size());
    for (int i = 0; i < to_groom_.size(); i++){
        if (to_groom_.at(i).size() <= max_length_){
            result.push_back(to_groom_.at(i));
        }
    }
    to_groom_ = result;
}