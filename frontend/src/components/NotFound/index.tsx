import React from 'react';
import { Link } from 'react-router-dom';
import './NotFound.css';

const NotFound: React.FC = () => {
  return (
    <div className="notfound-container">
      <h1 className="notfound-title">404</h1>
      <p className="notfound-message">
        Sorry, the page you're looking for doesn't exist.
      </p>
      <Link to="/" className="notfound-button">
        Go back home
      </Link>
    </div>
  );
};

export default NotFound;
