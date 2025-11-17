
 
# RAG Application for Mountain Peaks  
### C# · Semantic Kernel · Ollama · Qdrant

## Overview
This project implements a Retrieval-Augmented Generation (RAG) system for answering natural-language questions about well-known mountain peaks. It uses Semantic Kernel for orchestration, Ollama for local LLMs and embeddings, and Qdrant for vector storage. All computation is performed locally with no cloud dependency.

The application embeds descriptive information about each peak, stores it in a vector database, and retrieves the most relevant entries when the user asks a question. The LLM then generates a grounded answer using this retrieved context.

## Features
- Strongly typed vector record for peaks  
- Qdrant-based vector storage and semantic search  
- Local LLM and embedding generation via Ollama  
- High-quality curated dataset of major world peaks  
- Multi-turn conversation with maintained chat history  
- Optional plugin providing peak comparison  
- Fully offline operation  

## Architecture
1. User asks a question  
2. Query is embedded using a local embedding model  
3. Qdrant performs a similarity search  
4. Top-K peak descriptions are returned as context  
5. Semantic Kernel assembles the prompt with chat history  
6. Ollama’s LLM generates a grounded, contextual answer  

## Dataset
The system includes a curated list of major world peaks, such as:
- Eight-thousanders  
- Seven Summits  
- Other prominent mountains  

Each entry contains elevation, mountain range, first ascent year, continent, reference link, and a detailed description.

## Models
Requires two local models via Ollama:
- Chat model (e.g., gemma3:12b or similar)
- Embedding model: nomic-embed-text

Pull the models:
ollama pull nomic-embed-text
ollama pull gemma3:12b

powershell
Copy code

## Running Qdrant
Start Qdrant via Docker:
docker run -p 6333:6333 -p 6334:6334 qdrant/qdrant

 

## Running the Application
1. Start Ollama  
2. Start Qdrant  
3. Run the .NET application  
4. Ask questions like:
   - “Which peaks are part of the Karakoram range?”
   - “Compare Everest and K2.”
   - “Which peak was climbed first?”

Type `quit` to exit.

## Extending the System
- Add more peaks  
- Add technical difficulty ratings  
- Integrate real external APIs  
- Swap LLMs or embedding models  
- Enable tool-use only with tool-capable models  

## Summary
This project provides a complete, domain-specific RAG pipeline for peak-related knowledge. It combines structured data, semantic search, multi-turn chat, and local LLM inference into a cohesive and fully offline system.
