import React from 'react';
import { Typography } from 'antd';

const {Title} = Typography;

interface DefinitionVideoProps {
  url: string
}

const DefinitionVideo = ({ url }:DefinitionVideoProps) => {
  return (
    <div>
      <Title level={5}>Definition</Title>
      <iframe src={url}></iframe>
    </div>
  )
}

export default DefinitionVideo