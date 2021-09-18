cmake_minimum_required(VERSION 3.10)

project(Strategy VERSION 1.0
                DESCRIPTION "Refactoring to the strategy pattern"
                LANGUAGES CXX
                )

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED True)

FILE(GLOB SOURCES *.cpp)
add_executable(main ${SOURCES})

include_directories(dependencies/catch2 dependencies/trompeloeil-main/include)

target_precompile_headers(main PRIVATE dependencies/catch2/catch.hpp dependencies/trompeloeil-main/include/trompeloeil.hpp <string>)

set_source_files_properties(TestMain.cpp PROPERTIES SKIP_PRECOMPILE_HEADERS ON)