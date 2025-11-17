
# RAG Application in C# (.NET 9) Using Microsoft.Extensions.AI, Ollama, and Qdrant

### Retrieval-Augmented Generation with Local LLMs and Vector Search

### Dataset: Renowned Peaks

 

## Overview

This project implements a **Retrieval-Augmented Generation (RAG)** system using **.NET 9**, **Ollama**, **Qdrant**, and the updated **Microsoft.Extensions.AI** stack.  
The goal is to provide accurate, context-grounded answers by combining a local large language model with semantic search over a curated dataset of renowned mountain peaks.

The application runs **fully locally**, requires **no cloud services**, and enables conversational Q&A using high-quality vector retrieval.

 

## System Workflow

### 1. Local Models via Ollama

The application connects to a locally running Ollama instance and uses:

-   A **chat model** for generation
    
-   An **embedding model** for converting text into semantic vectors
    

Both run through `http://localhost:11434`, providing a private, cost-free inference environment.

 

### 2. Vector Database Using Qdrant

Qdrant acts as the vector storage layer, optimized for high-performance similarity search.  
The system:

-   Creates a **peaks** collection automatically if missing
    
-   Stores metadata and vector embeddings for each peak
    
-   Provides fast semantic retrieval during Q&A
    

The Qdrant Web UI is available at:

`http://localhost:6333/dashboard` 

 

### 3. Embedding the Peaks Dataset

A curated set of well-known peaks is loaded at startup.  
Each peak includes descriptive text and reference information, which is embedded using the selected embedding model.

The embeddings capture semantic meaning, enabling queries like:

-   _“Which peaks are located in the Himalayas?”_
    
-   _“Tell me about peaks known for extreme climbing difficulty.”_
    
-   _“Which is the tallest peak in Antarctica?”_
    

These queries work because the semantic vectors enable meaning-based matching, not keyword matching.

 

### 4. Retrieval and Context Construction

For every user query:

1.  The query text is embedded
    
2.  Qdrant returns the most similar peaks
    
3.  Duplicate entries are filtered
    
4.  A contextual block is constructed from the retrieved results
    
5.  The LLM receives a prompt containing:
    
    -   Retrieved context
        
    -   User question
        
    -   Instructions to rely strictly on context when answering
        

This ensures grounded, factual responses.

 

### 5. Conversation Memory

The system includes a lightweight in-memory history mechanism that stores recent interactions.  
This allows the model to handle referred questions such as:

-   _“Who first climbed it?”_
    
-   _“How tall is that one?”_
    

Only a limited number of entries are kept to avoid overflowing the model’s context window.

 

### 6. Response Streaming

The chat model output is streamed incrementally for improved responsiveness, similar to modern AI chat interfaces.

 

## What to Expect After Running the Application

-   The **peaks** collection is created in Qdrant (if not already present).
    
-   All peaks are embedded and stored once.
    
-   The application enters a loop where you can ask questions interactively.
    
-   Semantic search retrieves the closest matching peaks for each question.
    
-   The LLM generates answers based strictly on the retrieved context.
    
-   References can be displayed as part of the result.
    
-   Follow-up questions benefit from conversation history.
    
-   Everything runs locally and offline.
    

 

## Why This Architecture Works

-   **Local LLM execution** keeps data private and avoids inference costs.
    
-   **Vector search** ensures responses are contextually grounded.
    
-   **Streaming output** improves user experience.
    
-   **Conversation memory** makes the system more natural to interact with.
    
-   **.NET 9 and Microsoft.Extensions.AI** provide a modern and clean abstraction layer.
    
-   **Qdrant** handles similarity search efficiently and scales well.
