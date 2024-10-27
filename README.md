# RedisDemo

A .NET 8 console application demonstrating basic Redis operations. This project provides a simple example of connecting to a Redis server and performing fundamental data operations.

---

## Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## About the Project

RedisDemo is a basic .NET console application designed to demonstrate how to connect to a Redis server and perform simple key-value data operations. The project uses **Redis** as a fast, in-memory data store, suitable for caching and real-time data processing.

## Features

- Connects to a Redis server
- Demonstrates key-value pair insertion, retrieval, and deletion
- Compatible with .NET 8 and can be easily extended for more complex Redis operations

## Getting Started

### Prerequisites

- **.NET 8 SDK**: Ensure that the .NET 8 SDK is installed. You can download it from [here](https://dotnet.microsoft.com/download).
- **Redis Server**: Redis should be installed and running. For Windows users, it can be installed via Docker or with tools like Memurai. Alternatively, WSL can be used to install Redis on a Linux subsystem.

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/mahmut-bilir/RedisDemo.git
    cd RedisDemo
    ```

2. Restore dependencies:
    ```bash
    dotnet restore
    ```

3. Build the project:
    ```bash
    dotnet build
    ```

## Usage

1. **Start the Redis server** on your system. If you're using Docker, you can run:
   ```bash
   docker run --name redis-demo -p 6379:6379 redis
