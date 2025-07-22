import React from 'react';
import './Header.css';
import { Button, Typography } from 'antd';
import { Link } from 'react-router-dom';

const { Title } = Typography;

const Header: React.FC = () => {
  return (
    <header className="header">
      <Link to="/" className="header-logo">
        <Title level={3} style={{ margin: 0, color: 'white' }}>
          {import.meta.env.VITE_APP_NAME}
        </Title>
      </Link>
      <Button type="primary">Primary</Button>
    </header>
  );
};

export default Header;
