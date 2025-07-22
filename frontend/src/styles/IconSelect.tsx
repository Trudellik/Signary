import React, { useState } from 'react';
import { Dropdown, Button } from 'antd';
import { DownOutlined } from '@ant-design/icons';
import './IconSelect.css';

interface IconOption {
  key: string;
  icon: React.ReactNode;
}

interface IconSelectProps {
  options: IconOption[];
  onSelect: (key: string) => void;
  selected?: string;
}

const IconSelect: React.FC<IconSelectProps> = ({
  options,
  onSelect,
  selected,
}) => {
  const [visible, setVisible] = useState(false);

  const handleSelect = (key: string) => {
    onSelect(key);
    setVisible(false);
  };

  const menu = (
    <div className="icon-grid">
      {options.map((option) => (
        <div
          key={option.key}
          className={`icon-option ${selected === option.key ? 'selected' : ''}`}
          onClick={() => handleSelect(option.key)}
        >
          {option.icon}
        </div>
      ))}
    </div>
  );

  return (
    <Dropdown
      overlay={menu}
      trigger={['click']}
      open={visible}
      onOpenChange={setVisible}
    >
      <Button>
        Select Icon <DownOutlined />
      </Button>
    </Dropdown>
  );
};

export default IconSelect;
