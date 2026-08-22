const express = require('express');
const cors = require('cors');
const dotenv = require('dotenv');

dotenv.config();

const app = express();
const port = process.env.PORT || 5000;
const frontendUrl = process.env.FRONTEND_URL || 'http://localhost:5173';

app.use(cors({ origin: frontendUrl }));
app.use(express.json());

app.get('/api/health', (req, res) => {
  res.json({
    status: 'ok',
    message: 'Backend is running',
    timestamp: new Date().toISOString(),
  });
});

app.get('/api/example', (req, res) => {
  res.json({
    message: 'This is a starter API endpoint',
    data: {
      app: 'React Vite Template',
      environment: process.env.NODE_ENV || 'development',
    },
  });
});

app.listen(port, () => {
  console.log(`Backend listening on http://localhost:${port}`);
});
