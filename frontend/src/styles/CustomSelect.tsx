import React from 'react';
import { Select } from 'antd';
import type { SelectProps } from 'antd';

interface CustomSelectProps {
  options: SelectProps['options'];
  placeholder: string;
  onChange: (value: string | null) => void;
  size?: 'small' | 'middle' | 'large';
  value?: string;
  width?: string | number;
}

const CustomSelect: React.FC<CustomSelectProps> = ({
  options,
  size = 'large',
  placeholder,
  value,
  onChange,
  width = '200px',
}) => {
  return (
    <Select
      style={{ width, display: 'flex', alignItems: 'center' }}
      size={size}
      placeholder={placeholder}
      options={options}
      value={value}
      onChange={onChange}
      allowClear
    />
  );
};

export default CustomSelect;
